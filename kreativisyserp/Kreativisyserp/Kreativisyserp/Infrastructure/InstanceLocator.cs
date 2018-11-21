namespace Kreativisyserp.Infrastructure
{
    using ViewModels;
    //sirve para encontrar la Main View Model
    //tambien para ligar en las vistas a la Main View Model
    public class InstanceLocator
    {
        #region Properties
        public MainViewModel Main
        {
            get;
            set;
        }
        #endregion

        #region Constructors
        public InstanceLocator()
        {
            this.Main = new MainViewModel();
        }
        #endregion
    }
}
