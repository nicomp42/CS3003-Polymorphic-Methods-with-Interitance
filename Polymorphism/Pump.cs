using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism {
    class Pump: Device {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="ID">The Identifier of the Device</param>
        public Pump(String ID): base(ID)
        {
        }

        /// <summary>
        /// Start the Conveyor
        /// </summary>
        public override void Start()
        {
            Console.WriteLine("Starting Pump " + ID);
        }
        /// <summary>
        /// Stop the Conveyor
        /// </summary>
        public override void Stop()
        {
            Console.WriteLine("Stopping Pump " + ID);
        }
    }    }

