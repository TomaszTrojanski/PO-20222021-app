using PO_20222021_app.Exeptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO_20222021_app.Modele
{
    public class Wspolprace
    {
        private readonly IPromocjeProvider _promocjeProvider;
        private readonly IPromocjeCreator _promocjeCreator;
        private readonly IPromocjeConflictValidators _promocjeConflictValidators;
        
        public Wspolprace(IPromocjeProvider promocjeProvider, IPromocjeCreator promocjeCreator, IPromocjeConflictValidators promocjeConflictValidators)
        {
            _promocjeProvider = promocjeProvider;
            _promocjeCreator = promocjeCreator;
            _promocjeConflictValidators = promocjeConflictValidators;
        }
        public async Task<IEnumerable<Promocje>> GetAllPromocje()
        {
            return await _promocjeProvider.GetAllPromocje();
        }
        public async Task AddPromocje(Promocje promocje)
        {
            if (promocje.StartTime > promocje.EndTime)
            {
                throw new InvalidPromocjeTimeRangeException(promocje);
            }
            Promocje conflictingPromocje = await _promocjeConflictValidators.GetConflictingPromocje(promocje);

            if (conflictingPromocje != null)
            {
                throw new PromocjeConflictException(conflictingPromocje, promocje);
            }
            await _promocjeCreator.CreatePromocje(promocje);
        }
        
    }
}
