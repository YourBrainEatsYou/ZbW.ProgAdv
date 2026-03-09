namespace LeakyApp {
    public sealed class View {
        private readonly int _id;
        private readonly TickerService _service;

        public View(int id, TickerService service) {
            _id = id;
            _service = service;
            _service.Tick += this.OnTick; 
        }

        private void OnTick() {
            Console.WriteLine("Tick");
        }

        public void Close() {
            _service.Tick -= this.OnTick; 

        }
    }

}
