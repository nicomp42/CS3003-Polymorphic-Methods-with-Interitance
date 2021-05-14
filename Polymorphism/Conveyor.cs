/*************************************************************
 * Illustrate Polymorphic Methods.                           *
 *                                                           *
 * A class that derives from the abstract base class         *
 *                                                           *
 *                                                           *
 * Bill Nicholson                                            *
 *************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Conveyor: Device
    {

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="ID">The Identifier of the Device</param>
        public Conveyor(String ID): base(ID)
        {
        }

        /// <summary>
        /// Start the Conveyor
        /// </summary>
        public override void Start()
        {
            Console.WriteLine("Starting Conveyor " + ID);
        }
        /// <summary>
        /// Stop the Conveyor
        /// </summary>
        public override void Stop()
        {
            Console.WriteLine("Stopping Conveyor " + ID);
        }
    }
}
