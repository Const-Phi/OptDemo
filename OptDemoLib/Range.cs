namespace OptDemoLib
{
    public struct Range
    {
        public double Left;

        public double Right;

        public double GetLength() => Right - Left;

        public override string ToString() => $"[{Left}; {Right}]";
    }
}
