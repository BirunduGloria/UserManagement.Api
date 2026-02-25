namespace UserManagement.Api.Domain.ValueObjects
{
    public class Range
    {
        // EF Core needs a parameterless constructor
        private Range() { }

        public Range(decimal min, decimal max)
        {
            Min = min;
            Max = max;
        }

        public decimal Min { get; set; }  // Must have setter
        public decimal Max { get; set; }  // Must have setter
    }
}
