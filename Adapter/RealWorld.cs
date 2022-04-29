namespace Design_Pattern.Adapter
{
    /// <summary>
    /// Adapter Design Pattern
    /// </summary>
    /// <remarks>
    /// 演示了传统化学数据库的使用。
    /// 化合物对象通过适配器接口访问数据库。
    /// https://dofactory.com/net/adapter-design-pattern#realworld
    /// </remarks>
    public class RealWorld
    {
        public class Compound
        {
            protected float BoilingPoint;
            protected float MeltingPoint;
            protected double MolecularWeight;
            protected string MolecularFormula = null!;

            public virtual void Display()
            {
                Console.WriteLine("\nCompound:Unknown ------ ");
            }
        }

        public class RichCompound : Compound
        {
            private readonly string _chemical;
            private ChemicalDatabank _bank = null!;

            public RichCompound(string chemical)
            {
                _chemical=chemical;
            }

            public override void Display()
            {
               _bank=new ChemicalDatabank();

               BoilingPoint = _bank.GetCriticalPoint(_chemical, "B");
               MeltingPoint = _bank.GetCriticalPoint(_chemical, "M");
               MolecularWeight = _bank.GetMolecularWeight(_chemical);
               MolecularFormula = _bank.GetMolecularStructure(_chemical);

               Console.WriteLine($"\nCompound:{_chemical} ------ ");
               Console.WriteLine($" Formula:{MolecularFormula}");
               Console.WriteLine($" Weight:{MolecularWeight}");
               Console.WriteLine($" Melting Pt:{MeltingPoint}");
               Console.WriteLine($" Boiling Pt:{BoilingPoint}");
            }
        }

        public class ChemicalDatabank
        {
            public float GetCriticalPoint(string compound, string point)
            {
                if (point == "M")
                {
                    switch (compound.ToLower())
                    {
                        case "water": return 0.0f;
                        case "benzene": return 5.5f;
                        case "ethanol": return -114.1f;
                        default: return 0f;
                    }
                }
                else
                {
                    switch (compound.ToLower()) 
                    {
                        case "water": return 100.0f;
                        case "benzene": return 80.1f;
                        case "ethanol": return 78.3f;
                        default: return 0f;
                    }
                }
            }

            public string GetMolecularStructure(string compound)
            {
                switch (compound.ToLower())
                {
                    case "water": return "H20";
                    case "benzene": return "C6H6";
                    case "ethanol": return "C2H50H";
                    default: return "";
                }
            }

            public double GetMolecularWeight(string compound)
            {
                switch (compound.ToLower())
                {
                    case "water": return 18.015;
                    case "benzene": return 78.1134;
                    case "ethanol": return 446.0688;
                    default: return 0d;
                }
            }
        }
    }
}
