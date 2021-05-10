using ClassLibrary.StructPerformance;
using System.Diagnostics;
using Xunit;

namespace ClassLibrary.Tests
{
    public class StructEqualityPerformance
    {
        [Fact]
        public void ReferenceTypeMembersAndEqualsPerformance()
        {
            var nr_no_1 = new NoRefNoOverride { X = 1, Y = 2 };
            var nr_no_2 = new NoRefNoOverride { X = 1, Y = 2 };

            var wr_no_1 = new WithRefNoOverride { X = 1, Y = 2, Description = "struct wr1" };
            var wr_no_2 = new WithRefNoOverride { X = 1, Y = 2, Description = "struct wr2" };


            var timeWithNoReferenceMembers = CalculateEqualsPerformance(nr_no_1, nr_no_2);

            var timeWithReferenceMembers = CalculateEqualsPerformance(wr_no_1, wr_no_2);
        }

        [Fact]
        public void ReferenceTypeMembersAndOverriddenEquals()
        {
            var wr_no_1 = new WithRefNoOverride { X = 1, Y = 2, Description = "struct wo1" };
            var wr_no_2 = new WithRefNoOverride { X = 1, Y = 2, Description = "struct wo2" };

            var wr_wo_1 = new WithRefWithOverride { X = 1, Y = 2, Description = "struct w1" };
            var wr_wo_2 = new WithRefWithOverride { X = 1, Y = 2, Description = "struct w2" };


            var timeWithRefMembersAndNoOverriddenEquals =
                                                CalculateEqualsPerformance(wr_no_1, wr_no_2);

            var timeWithReferenceMembersAndWithOverriddenEquals =
                                                CalculateEqualsPerformance(wr_wo_1, wr_wo_2);
        }


        private long CalculateEqualsPerformance(object p1, object p2)
        {
            var sw = Stopwatch.StartNew();

            for (var i = 0; i < 10000000; i++)
            {
                p1.Equals(p2);
            }

            sw.Stop();

            return sw.ElapsedMilliseconds;
        }
    }
}
