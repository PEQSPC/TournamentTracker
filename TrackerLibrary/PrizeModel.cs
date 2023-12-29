using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    internal class PrizeModel
    {
        /// <summary>
        /// Lugar da qualificaçao
        /// </summary>
        public int PlaceNumber { get; set; }
        /// <summary>
        /// Nome da qualificacao 
        /// </summary>
        public string PlaceName { get; set; }
        /// <summary>
        /// Preço de cada qualificacao
        /// </summary>
        public int PrizeAmount { get; set; }
        
        public double PrizePercentage { get; set; }
    }
}
