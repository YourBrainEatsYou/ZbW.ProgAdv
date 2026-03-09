
namespace LeakyApp {
    public sealed class TickerService {
        public event Action Tick;

        public void RaiseTick() {
            this.Tick?.Invoke();
        }
    }
}
