namespace ProgAdvI.MB04_02.Equality.Repetition.Exercise {
    public class Vector : ICloneable {
        public int X { get; set; }
        public int Y { get; set; }

        public override bool Equals(object? obj) {
            return obj is Vector v &&
                   X == v.X &&
                   Y == v.Y;
        }

        public override int GetHashCode() {
            return HashCode.Combine(this.X, this.Y);
        }

        public void Add(Vector other) {
            // Vektoren werden addiert, indem die jeweiligen Komponenten addiert werden
            X += other.X;
            Y += other.Y;
        }

        public object Clone() {
            return this.MemberwiseClone();
        }

        public override string ToString() {
            return $"Vector({X}, {Y})";
        }
    }

}
