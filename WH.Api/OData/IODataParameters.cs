namespace WH.Api.OData
{
    public interface IODataParameters
    {
        int? Top { get; }
        string GetCountUri(DateTime? begin = null, DateTime? end = null);
        string GetUri(DateTime? begin = null, DateTime? end = null, int? iteration = null);

        public int GetIterationsCount(int? odataCount)
        {
            int iterations = 0;
            if (odataCount != null && Top != null)
                iterations = (int)Math.Ceiling((double)odataCount / (double)(Top));
            return iterations;
        }
    }
}