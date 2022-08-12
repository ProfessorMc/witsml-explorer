using System;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Http;

using WitsmlExplorer.Api.Services;

namespace WitsmlExplorer.Api.HttpHandler;

public static class WbGeometryHandler
{
    public static async Task<IResult> GetWbGeometries(string wellUid, string wellboreUid, IWbGeometryService wbGeometryService)
    {
        try
        {
            return Results.Ok(await wbGeometryService.GetWbGeometrys(wellUid, wellboreUid));
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }
}
