using System;

namespace TestProjectDAL.Entity
{
    public class StateDailyDAO
    {
        public DateTime? Date { get; set; }
        public string State { get; set; }
        public int? Positive { get; set; }
        public string ProbableCases { get; set; }
        public string Negative { get; set; }
        public string Pending { get; set; }
        public string TotalTestResultsSource { get; set; }
        public int? TotalTestResults { get; set; }
        public int? HospitalizedCurrently { get; set; }
        public int? HospitalizedCumulative { get; set; }
        public string InIcuCurrently { get; set; }
        public string InIcuCumulative { get; set; }
        public int? OnVentilatorCurrently { get; set; }
        public string OnVentilatorCumulative { get; set; }
        public string Recovered { get; set; }
        public DateTime? LastUpdateEt { get; set; }
        public DateTime? DateModified { get; set; }
        public string CheckTimeEt { get; set; }
        public int? Death { get; set; }
        public int? Hospitalized { get; set; }
        public string HospitalizedDischarged { get; set; }
        public DateTime? DateChecked { get; set; }
        public int? TotalTestsViral { get; set; }
        public int? PositiveTestsViral { get; set; }
        public int? NegativeTestsViral { get; set; }
        public string PositiveCasesViral { get; set; }
        public string DeathConfirmed { get; set; }
        public string DeathProbable { get; set; }
        public string TotalTestEncountersViral { get; set; }
        public string TotalTestsPeopleViral { get; set; }
        public string TotalTestsAntibody { get; set; }
        public string PositiveTestsAntibody { get; set; }
        public string NegativeTestsAntibody { get; set; }
        public string TotalTestsPeopleAntibody { get; set; }
        public string PositiveTestsPeopleAntibody { get; set; }
        public string NegativeTestsPeopleAntibody { get; set; }
        public string TotalTestsPeopleAntigen { get; set; }
        public string PositiveTestsPeopleAntigen { get; set; }
        public string TotalTestsAntigen { get; set; }
        public string PositiveTestsAntigen { get; set; }
        public int? Fips { get; set; }
        public string PositiveIncrease { get; set; }
        public string NegativeIncrease { get; set; }
        public int? Total { get; set; }
        public string TotalTestResultsIncrease { get; set; }
        public int? PosNeg { get; set; }
        public string DataQualityGrade { get; set; }
        public string DeathIncrease { get; set; }
        public string HospitalizedIncrease { get; set; }
        public string Hash { get; set; }
        public string CommercialScore { get; set; }
        public string NegativeRegularScore { get; set; }
        public string NegativeScore { get; set; }
        public string PositiveScore { get; set; }
        public string Score { get; set; }
        public string Grade { get; set; }
        public int Id { get; set; }

        public StateDailyDAO(StatesDaily command)
        {
            Date = command.date;
            State = command.state;
            Positive = command.positive;
            ProbableCases = command.probableCases;
            Negative = command.negative;
            Pending = command.pending;
            TotalTestResultsSource = command.totalTestResultsSource;
            TotalTestResults = command.totalTestResults;
            HospitalizedCurrently = command.hospitalizedCurrently;
            HospitalizedCumulative = command.hospitalizedCumulative;
            InIcuCurrently = command.inIcuCurrently;
            InIcuCumulative = command.inIcuCumulative;
            OnVentilatorCurrently = command.onVentilatorCurrently;
            OnVentilatorCumulative = command.onVentilatorCumulative;
            Recovered = command.recovered;
            LastUpdateEt = command.lastUpdateEt;
            DateModified = command.dateModified;
            CheckTimeEt = command.checkTimeEt;
            Death = command.death;
            Hospitalized = command.hospitalized;
            HospitalizedDischarged = command.hospitalizedDischarged;
            DateChecked = command.dateChecked;
            TotalTestsViral = command.totalTestsViral;
            PositiveTestsViral = command.positiveTestsViral;
            NegativeTestsViral = command.negativeTestsViral;
            PositiveCasesViral = command.positiveCasesViral;
            DeathConfirmed = command.deathConfirmed;
            DeathProbable = command.deathProbable;
            TotalTestEncountersViral = command.totalTestEncountersViral;
            TotalTestsPeopleViral = command.totalTestsPeopleViral;
            TotalTestsAntibody = command.totalTestsAntibody;
            PositiveTestsAntibody = command.positiveTestsAntibody;
            NegativeTestsAntibody = command.negativeTestsAntibody;
            TotalTestsPeopleAntibody = command.totalTestsPeopleAntibody;
            PositiveTestsPeopleAntibody = command.positiveTestsPeopleAntibody;
            NegativeTestsPeopleAntibody = command.negativeTestsPeopleAntibody;
            TotalTestsPeopleAntigen = command.totalTestsPeopleAntigen;
            PositiveTestsPeopleAntigen = command.positiveTestsPeopleAntigen;
            TotalTestsAntigen = command.totalTestsAntigen;
            PositiveTestsAntigen = command.positiveTestsAntigen;
            Fips = command.fips;
            PositiveIncrease = command.positiveIncrease;
            NegativeIncrease = command.negativeIncrease;
            Total = command.total;
            TotalTestResultsIncrease = command.totalTestResultsIncrease;
            PosNeg = command.posNeg;
            DataQualityGrade = command.dataQualityGrade;
            DeathIncrease = command.deathIncrease;
            HospitalizedIncrease = command.hospitalizedIncrease;
            Hash = command.hash;
            CommercialScore = command.commercialScore;
            NegativeRegularScore = command.negativeRegularScore;
            NegativeScore = command.negativeScore;
            PositiveScore = command.positiveScore;
            Score = command.score;
            Grade = command.grade;

        }
    }
}
