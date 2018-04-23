using FilterExtensions.Utility;
using System;
using System.Collections.Generic;
using System.Text;

namespace FilterExtensions.ConfigNodes.CheckNodes
{
    /// <summary>
    /// adds equality to the mix
    /// </summary>
    public abstract class CheckNodeNumeric : CheckNode
    {
        protected CompareType Equality { get; }
        protected CheckNodeNumeric(ConfigNode node) : base(node)
        {
            Equality = LoadEquality(node);
        }

        public override ConfigNode ToConfigNode()
        {
            var node = base.ToConfigNode();
            node.AddValue("equality", Equality.ToString());
            return node;
        }
    }

    /// <summary>
    /// check part attach nodes size
    /// </summary>
    public class CheckSize : CheckNodeNumeric
    {
        public const string ID = "size";
        public override string CheckID { get => ID; }
        bool Contains { get; }
        bool Exact { get; }

        public CheckSize(ConfigNode node) : base(node)
        {
            Contains = LoadContains(node);
            Exact = LoadExact(node);
        }

        public override bool CheckResult(AvailablePart part, int depth = 0)
        {
            return Invert ^ PartType.CheckPartSize(part, Values, Contains, Equality, Exact);
        }

        public override ConfigNode ToConfigNode()
        {
            var node = base.ToConfigNode();
            node.AddValue("contains", Contains.ToString());
            node.AddValue("exact", Exact.ToString());
            return node;
        }
    }

    /// <summary>
    /// check part crew capacity
    /// </summary>
    public class CheckCrew : CheckNodeNumeric
    {
        public const string ID = "crew";
        public override string CheckID { get => ID; }

        public CheckCrew(ConfigNode node) : base(node) { }
        public override bool CheckResult(AvailablePart part, int depth = 0)
        {
            return Invert ^ PartType.CheckCrewCapacity(part, Values, Equality);
        }
    }

    /// <summary>
    /// check part dry mass
    /// </summary>
    public class CheckMass : CheckNodeNumeric
    {
        public const string ID = "mass";
        public override string CheckID { get => ID; }

        public CheckMass(ConfigNode node) : base(node) { }
        public override bool CheckResult(AvailablePart part, int depth = 0)
        {
            return Invert ^ PartType.CheckMass(part, Values, Equality);
        }
    }

    /// <summary>
    /// check part dry cost
    /// </summary>
    public class CheckCost : CheckNodeNumeric
    {
        public const string ID = "cost";
        public override string CheckID { get => ID; }

        public CheckCost(ConfigNode node) : base(node) { }
        public override bool CheckResult(AvailablePart part, int depth = 0)
        {
            return Invert ^ PartType.CheckCost(part, Values, Equality);
        }
    }

    /// <summary>
    /// check part crash tolerance
    /// </summary>
    public class CheckCrash : CheckNodeNumeric
    {
        public const string ID = "crash";
        public override string CheckID { get => ID; }

        public CheckCrash(ConfigNode node) : base(node) { }
        public override bool CheckResult(AvailablePart part, int depth = 0)
        {
            return Invert ^ PartType.CheckCrashTolerance(part, Values, Equality);
        }
    }

    /// <summary>
    /// check part max temperature
    /// </summary>
    public class CheckMaxTemp : CheckNodeNumeric
    {
        public const string ID = "maxTemp";
        public override string CheckID { get => ID; }

        public CheckMaxTemp(ConfigNode node) : base(node) { }
        public override bool CheckResult(AvailablePart part, int depth = 0)
        {
            return Invert ^ PartType.CheckTemperature(part, Values, Equality);
        }
    }

	/// <summary>
	/// checks part engine thrust
	/// </summary>
	public class CheckThrust : CheckNodeNumeric
	{
		public const string ID = "thrust";
		public override string CheckID { get => ID; }

		public CheckThrust(ConfigNode node) : base(node) { }
		public override bool CheckResult(AvailablePart part, int depth = 0)
		{
			return Invert ^ PartType.CheckThrust(part, Values, Equality);
		}
	}

	/// <summary>
	/// checks part engine ISP Atmo
	/// </summary>
	public class CheckISP_Atmo : CheckNodeNumeric
	{
		public const string ID = "isp_atm";
		public override string CheckID { get => ID; }

		public CheckISP_Atmo(ConfigNode node) : base(node) { }
		public override bool CheckResult(AvailablePart part, int depth = 0)
		{
			return Invert ^ PartType.CheckISP(part, Values, Equality, false);
		}
	}

    /// <summary>
    /// checks part engine ISP Vac
    /// </summary>
    public class CheckISP_Vac : CheckNodeNumeric
    {
        public const string ID = "isp_vac";
        public override string CheckID { get => ID; }

        public CheckISP_Vac(ConfigNode node) : base(node) { }
        public override bool CheckResult(AvailablePart part, int depth = 0)
        {
            return Invert ^ PartType.CheckISP(part, Values, Equality, true);
        }
    }
}
