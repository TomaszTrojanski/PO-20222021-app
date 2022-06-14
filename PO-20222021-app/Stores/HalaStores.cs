using PO_20222021_app.Modele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO_20222021_app.Stores
{
    public class HalaStores
    {
        private readonly Hala _hala;
        private readonly List<Promocje> _promocje;
        private Lazy<Task> _initializeLazy;

        public IEnumerable<Promocje> Promocjes => _promocje;
        public event Action<Promocje> PromocjeMade;

        public HalaStores(Hala hala)
        {
            _hala = hala;
            _initializeLazy = new Lazy<Task>(Initialize);
            _promocje = new List<Promocje>();
        }
        public async Task Load()
        {
            try{
                await _initializeLazy.Value;
            }
            catch (Exception)
            {
                _initializeLazy = new Lazy<Task>(Initialize);
                throw;
            }
        }
        public async Task MakePromocje(Promocje promocje)
        {
            await _hala.MakePromocje(promocje);
            _promocje.Add(promocje);
            OnPromocjeMade(promocje);
        }

        private void OnPromocjeMade(Promocje promocje)
        {
            PromocjeMade?.Invoke(promocje);
        }

        private async Task Initialize()
        {
            IEnumerable<Promocje> promocjes = await _hala.GetAllPromocje();
            _promocje.Clear();
            _promocje.AddRange(promocjes);
        }
    }
}    
