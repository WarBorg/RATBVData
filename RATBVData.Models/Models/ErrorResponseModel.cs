using Newtonsoft.Json;

namespace RATBVData.Models.Models
{
    public class ErrorResponseModel
    {
        [JsonProperty("errorType")]
        public string ErrorType { get; }

        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; }

        public ErrorResponseModel(string errorType, string errorMessage)
            => (ErrorType, ErrorMessage) = (errorType, errorMessage);
    }
}