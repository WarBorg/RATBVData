using Newtonsoft.Json;

namespace RATBVData.Models.Models
{
    public class ErrorResponseModel
    {
        [JsonProperty("errorType")]
        public string ErrorType { get; set; } = string.Empty;

        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; } = string.Empty;
    }
}