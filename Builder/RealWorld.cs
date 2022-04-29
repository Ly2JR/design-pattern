namespace Design_Pattern.Builder
{
    /// <summary>
    /// Builder Design Pattern
    /// </summary>
    /// <remarks>
    /// 演示了构建起模式，其中不同的车辆以逐步的方式组装。
    /// 商店使用VehicleBuilders以一系列顺序步骤构建各种车辆。
    /// https://dofactory.com/net/builder-design-pattern#realworld
    /// </remarks>
    public class RealWorld
    {
        public class Shop
        {
            public void Construct(VehicleBuilder vehicleBuilder)
            {
                vehicleBuilder.BuildFrame();
                vehicleBuilder.BuildEngine();
                vehicleBuilder.BuildWheels();
                vehicleBuilder.BuildDoors();
            }
        }

        public abstract class VehicleBuilder
        {
            public Vehicle Vehicle { get; protected set; } = null!;

            public abstract void BuildFrame();
            public abstract void BuildEngine();
            public abstract void BuildWheels();
            public abstract void BuildDoors();
        }

        public class MotorCycleBuilder:VehicleBuilder
        {
            public MotorCycleBuilder()
            {
                Vehicle = new Vehicle("MotorCycle");
            }

            public override void BuildFrame()
            {
                Vehicle["frame"] = "MotorCycle Frame";
            }

            public override void BuildEngine()
            {
                Vehicle["engine"] = "500 cc";
            }

            public override void BuildWheels()
            {
                Vehicle["wheels"] = "2";
            }

            public override void BuildDoors()
            {
                Vehicle["doors"] = "0";
            }
        }

        public class CarBuilder:VehicleBuilder
        {
            public CarBuilder()
            {
                Vehicle = new Vehicle("Car");
            }

            public override void BuildFrame()
            {
                Vehicle["frame"] = "Car Frame";
            }

            public override void BuildEngine()
            {
                Vehicle["engine"] = "2500 cc";
            }

            public override void BuildWheels()
            {
                Vehicle["wheels"] = "4";
            }

            public override void BuildDoors()
            {
                Vehicle["doors"] = "4";
            }
        }

        public class ScooterBuilder:VehicleBuilder
        {
            public ScooterBuilder()
            {
                Vehicle = new Vehicle("Scooter");
            }

            public override void BuildFrame()
            {
                Vehicle["frame"] = "Scooter Frame";
            }

            public override void BuildEngine()
            {
                Vehicle["engine"] = "50 cc";
            }

            public override void BuildWheels()
            {
                Vehicle["wheels"] = "2";
            }

            public override void BuildDoors()
            {
                Vehicle["doors"]="0";
            }
        }

        public class Vehicle
        {
            private readonly string _vehicleType;
            private readonly Dictionary<string,string> _parts=new Dictionary<string,string>();

            public Vehicle(string vehicleType)
            {
                _vehicleType=vehicleType;
            }

            public string this[string key]
            {
                get => _parts[key];
                set => _parts[key] = value;
            }

            public void Show()
            {
                Console.WriteLine("\n--------------------------");
                Console.WriteLine($"Vehicle Type:{_vehicleType}");
                Console.WriteLine($" Frame:{_parts["frame"]}");
                Console.WriteLine($" Engine:{_parts["engine"]}");
                Console.WriteLine($" #Wheels:{_parts["wheels"]}");
                Console.WriteLine($" #Doors:{_parts["doors"]}");
            }
        }
    }
}
