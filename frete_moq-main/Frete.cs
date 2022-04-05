using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreteApp02
{
    public class Frete
    {
        public int Cep { get; set; }
        public double Peso { get; set; }

        private ICorreioService correioService;

        public Frete(ICorreioService _correioService)
        {
            correioService = _correioService;
			
			//adicionalFrete => Taxa
			
			if (correioService.Peso <= 5) {
				return correioService.CalculaFrete() + 5;
			}
			else{
				if(correioService.Peso  > 6 && correioService.Peso<=8){
					return correioService.CalculaFrete() + 10;
				}
				else{
					return correioService.CalculaFrete() + 15;
				}
			}
        }
        
    }
}
