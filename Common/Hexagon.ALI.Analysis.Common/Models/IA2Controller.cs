using Hexagon.ALI.Analysis.Common.Classes;
using Hexagon.ALI.Analysis.Common.Classes.Analysis;
using Hexagon.ALI.Analysis.Common.Classes.Analysis.Abstract;
using Hexagon.ALI.Analysis.Common.Classes.Analysis.LoadCase;
using Hexagon.ALI.Analysis.Common.Classes.SIO;
using Hexagon.ALI.Analysis.Common.DTOs;
using Hexagon.ALI.Analysis.Common.DTOs.Enums;
using Hexagon.ALI.Analysis.Common.Enums;
using Hexagon.ALI.Analysis.Common.Helpers.Units;
using Hexagon.ALI.Analysis.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace Hexagon.ALI.Analysis.Helper
{
    public class DatabaseException : Exception
    {
        public DatabaseException() : base() { }
     
        public DatabaseException(string message) : base(message) { }

        public DatabaseException(string message, Exception innerException) : base(message, innerException) { }
    }

    public interface IA2Controller
    {
        event EventHandler<InputOutputChangedEventArgs> InputOutputChangedEvent;
        Task<IA2Controller> CreateSeparateConnection();
        Task OpenAsync(string path);
        Task CloseAsync();
        TranslationOutput TranslateC2(string pathToC2File);
        Task<ExecutionMetadata> SavePipingSystem(PipingSystem pipingSystem, bool forceDelete = true);
        Task<PipingSystem> GetPipingSystem();
        Task<IEnumerable<AnalysisLoadCase>> GetLoadCasesAsync(Expression<Func<AnalysisLoadCase, bool>> filter = null, CancellationToken ct = default);
        Task<IEnumerable<AnalysisNode>> GetNodesAsync(DbQueryOptions<AnalysisNode> queryOptions);
        Task<IEnumerable<TNodeAuxiliary>> GetNodeAuxiliariesAsync<TNodeAuxiliary>(Expression<Func<TNodeAuxiliary, bool>> filter = null, CancellationToken ct = default) where TNodeAuxiliary : AnalysisNodeAuxiliary;
        Task<IEnumerable<AnalysisLineElement>> GetElementsAsync(DbQueryOptions<AnalysisLineElement> queryOptions);
        Task<IEnumerable<UserUnits>> GetUnitsAsync(Expression<Func<UserUnits, bool>> filter = null, CancellationToken ct = default);
        Task<Tuple<double, AnalysisNode>> GetMaximumValue(PropertiesForMaxValue property, CoordinateForMaxValue coordinate, string loadCaseID, CancellationToken ct = default);
        Task<GroupedDataLineElementReturn> DisplayGroupedData(PropertiesForGrouping property, CancellationToken ct = default);
        Task<GroupedDataUniformLoadReturn> DisplayUniformLoadsGrouped(PropertiesForGrouping property, CancellationToken ct = default);
        Task<GroupedDataWaveReturn> DisplayWavesGrouped(PropertiesForGrouping property, CancellationToken ct = default);
        Task<GroupedDataWindReturn> DisplayWindsGrouped(PropertiesForGrouping property, CancellationToken ct = default);
        Task<GroupedDataRestraintReturn> DisplayRestraintsGrouped(PropertiesForGrouping property, CancellationToken ct = default);
        Task<List<TeeOverlayDataReturn>> DisplayTeeOverlay(CancellationToken ct = default);
        Task<List<OverstressedDataReturn>> DisplayOverstressedNodesAsync(string loadCaseID, CancellationToken ct = default);
        Task<HeatmapsDataReturn> DisplayStressByValueAsync(string loadCaseID, CancellationToken ct = default);
        Task<HeatmapsDataReturn> DisplayStressByPercentAsync(string loadCaseID, CancellationToken ct = default);
        Task<List<int>> GetVectorNumbers(PrimitiveType primitiveType, CancellationToken ct = default);
        Task<List<LineNumbersData>> DisplayLineNumbers(CancellationToken ct = default);
        Task<IEnumerable<MetadataInput>> GetMetadataInputAsync(Expression<Func<MetadataInput, bool>> filter = null, CancellationToken ct = default);
        Task<string> GetReportBooks(CancellationToken ct = default);
        Task<string> SetReportBooks(string reportBookJson, CancellationToken ct = default);
    }
}
