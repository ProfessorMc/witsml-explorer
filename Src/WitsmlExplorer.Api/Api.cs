using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

using WitsmlExplorer.Api.HttpHandler;

namespace WitsmlExplorer.Api;

public static class Api
{
    public static void ConfigureApi(this WebApplication app)
    {

        app.MapGet("/api/witsml-servers", WitsmlServerHandler.GetWitsmlServers);
        app.MapPost("/api/witsml-servers", WitsmlServerHandler.CreateWitsmlServer);
        app.MapMethods("/api/witsml-servers/{witsmlServerId}", new[] { HttpMethods.Patch }, WitsmlServerHandler.UpdateWitsmlServer);
        app.MapDelete("/api/witsml-servers/{witsmlServerId}", WitsmlServerHandler.DeleteWitsmlServer);

        app.MapGet("/api/wells", WellHandler.GetAllWells);
        app.MapGet("/api/wells/{wellUid}", WellHandler.GetWell);
        app.MapGet("/api/wells/{wellUid}/wellbores/{wellboreUid}/wbGeometrys", WbGeometryHandler.GetWbGeometries);
        app.MapGet("/api/wells/{wellUid}/wellbores/{wellboreUid}/risks", RiskHandler.GetRisks);
        app.MapGet("/api/wells/{wellUid}/wellbores/{wellboreUid}/tubulars", TubularHandler.GetTubulars);
        app.MapGet("/api/wells/{wellUid}/wellbores/{wellboreUid}/tubulars/{tubularUid}", TubularHandler.GetTubular);
        app.MapGet("/api/wells/{wellUid}/wellbores/{wellboreUid}/tubulars/{tubularUid}/tubularcomponents", TubularHandler.GetTubularComponents);
        app.MapGet("/api/wells/{wellUid}/wellbores/{wellboreUid}/messages", MessageHandler.GetMessages);
        app.MapGet("/api/wells/{wellUid}/wellbores/{wellboreUid}/messages/{messageUid}", MessageHandler.GetMessage);
        app.MapGet("/api/wells/{wellUid}/wellbores/{wellboreUid}/bharuns", BhaRunHandler.GetBhaRuns);
        app.MapGet("/api/wells/{wellUid}/wellbores/{wellboreUid}/bharuns/{bhaRunUid}", BhaRunHandler.GetBhaRun);
        app.MapGet("/api/wells/{wellUid}/wellbores/{wellboreUid}/rigs", RigHandler.GetRigs);
        app.MapGet("/api/wells/{wellUid}/wellbores/{wellboreUid}/rigs/{rigUid}", RigHandler.GetRig);

        app.MapGet("/api/wells/{wellUid}/wellbores/{wellboreUid}/logs/{logUid}", LogHandler.GetLog);
        app.MapGet("/api/wells/{wellUid}/wellbores/{wellboreUid}/logs", LogHandler.GetLogs);
        app.MapGet("/api/wells/{wellUid}/wellbores/{wellboreUid}/logs/{logUid}/logcurveinfo", LogHandler.GetLogCurveInfo);



    }
}
