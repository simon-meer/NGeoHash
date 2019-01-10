namespace NGeoHash
{
    public struct GeohashDecodeResult
    {
        public Coordinates Coordinates { get; set; }
        public Coordinates Error { get; set; }
    }
}