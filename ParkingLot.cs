using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace park
{
    public class ParkingLot
    {
        #region private attributes
        private double _capacity;
        private double _vacancy;
        #endregion private attributes

        #region public methods
        public ParkingLot (double capacity)
        {

        }

        public void Park(Car car)
        {

        }

        public double Vacancy
        {
            get 
            {
                throw new NotImplementedException();
            }

        }
        #endregion public methods
    }
}