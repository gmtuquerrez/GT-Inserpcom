using System;
using System.Globalization;

namespace TestProjectDAL.Entity
{
    public class UsDailyDAO
    {
        public DateTime? Date { get; set; }
        public int? States { get; set; }
        public int? Positive { get; set; }
        public int? Negative { get; set; }
        public int? Pending { get; set; }
        public int? HospitalizedCurrently { get; set; }
        public int? HospitalizedCumulative { get; set; }
        public int? InIcuCurrently { get; set; }
        public int? InIcuCumulative { get; set; }
        public int? OnVentilatorCurrently { get; set; }
        public int? OnVentilatorCumulative { get; set; }
        public string DateChecked { get; set; }
        public int? Death { get; set; }
        public int? Hospitalized { get; set; }
        public int? TotalTestResults { get; set; }
        public string LastModified { get; set; }
        public string Recovered { get; set; }
        public string Total { get; set; }
        public string PosNeg { get; set; }
        public int? DeathIncrease { get; set; }
        public int? HospitalizedIncrease { get; set; }
        public int? NegativeIncrease { get; set; }
        public int? PositiveIncrease { get; set; }
        public int? TotalTestResultsIncrease { get; set; }
        public string Hash { get; set; }
        public int Id { get; set; }

        public UsDailyDAO(UsDaily command)
        {
            Date = command.date;
            States = command.states;
            Positive = command.positive;
            Negative = command.negative;
            Pending = command.pending;
            HospitalizedCurrently = command.hospitalizedCurrently;
            HospitalizedCumulative = command.hospitalizedCumulative;
            InIcuCurrently = command.inIcuCurrently;
            InIcuCumulative = command.inIcuCumulative;
            OnVentilatorCurrently = command.onVentilatorCurrently;
            OnVentilatorCumulative = command.onVentilatorCumulative;
            DateChecked = command.dateChecked;
            Death = command.death;
            HospitalizedIncrease = command.hospitalizedIncrease;
            NegativeIncrease = command.negativeIncrease;
            PositiveIncrease = command.positiveIncrease;
            TotalTestResultsIncrease = command.totalTestResultsIncrease;
            Hash = command.hash;
        }
    }
}
