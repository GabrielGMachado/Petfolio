// Isso aqui só existe pra poder transformar em JSON.

namespace Petfolio.Communication.Responses;

public class ResponseErrorJson
{
    public List<string> Errors { get; set; } = [];

    public ResponseErrorJson(List<string> errors)
    {
        Errors = errors;
    }
}
