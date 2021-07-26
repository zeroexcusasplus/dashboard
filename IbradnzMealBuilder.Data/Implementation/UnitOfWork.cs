using IbradnzMealBuilder.Data.Contract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace IbradnzMealBuilder.Data.Implementation
{

    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly ApplicationDbContext _context;
        public CustomerRepo CustomerRepo { get; set; }
        public MealTypeRepo MealTypeRepo { get; set; }
        public MealRepo MealRepo { get; set; }
        public MealBuilderRepo MealBuilderRepo { get; set; }
        public SubscriptionRepo SubscriptionRepo { get; set; }
        public TrainingVideoRepo TrainingVideoRepo { get; set; }
        public ProfileImageRepo ProfileImageRepo { get; set; }
        public TechniqueVideoRepo TechniqueVideoRepo { get; set; }
        public LiveZoomRepo LiveZoomRepo { get; set; }
        public TrainingDayRepo TrainingDayRepo { get; set; }
        public CountryPhoneCodeRepo CountryPhoneCodeRepo { get; set; }
        public FaqRepo FaqRepo { get; set; }
        public ProgramRepo ProgramRepo { get; set; }
        public MuscleGroupRepo MuscleGroupRepo { get; set; }

        public UnitOfWork(ApplicationDbContext context)
        {
            this._context = context;
            this.CustomerRepo = new CustomerRepo(this._context);
            this.MealTypeRepo = new MealTypeRepo(this._context);
            this.MealRepo = new MealRepo(this._context);
            this.MealBuilderRepo = new MealBuilderRepo(this._context);
            this.SubscriptionRepo = new SubscriptionRepo(this._context);
            this.TrainingVideoRepo = new TrainingVideoRepo(this._context);
            this.ProfileImageRepo = new ProfileImageRepo(this._context);
            this.TechniqueVideoRepo = new TechniqueVideoRepo(this._context);
            this.LiveZoomRepo = new LiveZoomRepo(this._context);
            this.TrainingDayRepo = new TrainingDayRepo(this._context);
            this.CountryPhoneCodeRepo = new CountryPhoneCodeRepo(this._context);
            this.FaqRepo = new FaqRepo(this._context);
            this.ProgramRepo = new ProgramRepo(this._context);
            this.MuscleGroupRepo = new MuscleGroupRepo(this._context);
        }

        public async Task Save()
        {
            await this._context.SaveChangesAsync();
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~UnitOfWork()
        // {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
        #endregion
    }
}
