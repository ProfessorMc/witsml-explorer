using System;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Http;

using WitsmlExplorer.Api.Services;

namespace WitsmlExplorer.Api.HttpHandler;

public static class RiskHandler
{
    public static async Task<IResult> GetRisks(string wellUid, string wellboreUid, IRiskService riskService)
    {
        try
        {
            return Results.Ok(await riskService.GetRisks(wellUid, wellboreUid));
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }
}
