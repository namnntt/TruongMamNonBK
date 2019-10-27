using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BussinesLayer
{
    public static class ExtensionServices
    {
        #region Full outerjoin IENumerable
        internal static IList<TR> FullOuterGroupJoin<TA, TB, TK, TR>(
       this IEnumerable<TA> a,
       IEnumerable<TB> b,
       Func<TA, TK> selectKeyA,
       Func<TB, TK> selectKeyB,
       Func<IEnumerable<TA>, IEnumerable<TB>, TK, TR> projection,
       IEqualityComparer<TK> cmp = null)
        {
            cmp = cmp ?? EqualityComparer<TK>.Default;
            var alookup = a.ToLookup(selectKeyA, cmp);
            var blookup = b.ToLookup(selectKeyB, cmp);

            var keys = new HashSet<TK>(alookup.Select(p => p.Key), cmp);
            keys.UnionWith(blookup.Select(p => p.Key));

            var join = from key in keys
                       let xa = alookup[key]
                       let xb = blookup[key]
                       select projection(xa, xb, key);

            return join.ToList();
        }

        internal static IList<TR> FullOuterJoin<TA, TB, TK, TR>(
            this IEnumerable<TA> a,
            IEnumerable<TB> b,
            Func<TA, TK> selectKeyA,
            Func<TB, TK> selectKeyB,
            Func<TA, TB, TK, TR> projection,
            TA defaultA = default(TA),
            TB defaultB = default(TB),
            IEqualityComparer<TK> cmp = null)
        {
            cmp = cmp ?? EqualityComparer<TK>.Default;
            var alookup = a.ToLookup(selectKeyA, cmp);
            var blookup = b.ToLookup(selectKeyB, cmp);

            var keys = new HashSet<TK>(alookup.Select(p => p.Key), cmp);
            keys.UnionWith(blookup.Select(p => p.Key));

            var join = from key in keys
                       from xa in alookup[key].DefaultIfEmpty(defaultA)
                       from xb in blookup[key].DefaultIfEmpty(defaultB)
                       select projection(xa, xb, key);

            return join.ToList();
        }
        #endregion

        public static bool PhoneVietNamValidation(this string txt)
        {
            Regex r = new Regex(@"((09|03|07|08|05)+([0-9]{8})\b)");
            if (!(r.IsMatch(txt)))
            {
                return true;
            }
            else return false;
        }
        public static bool EmailValidation(this string txt)
        {
            Regex r = new Regex(@"^[a-z][a-z0-9_\.]{5,32}@[a-z0-9]{2,}(\.[a-z0-9]{2,4}){1,2}$");
            if (!(r.IsMatch(txt)))
            {
                return true;
            }
            else return false;
        }

    }
}
