using System;
using System.Resources;
using System.IO;
using Microsoft.SqlServer.Dts.Pipeline;
using Microsoft.SqlServer.Dts.Pipeline.Wrapper;

namespace CustomDataFlowComponent
{
    [DtsPipelineComponent(DisplayName = "CustomDataFlowComponent", ComponentType = ComponentType.SourceAdapter)]
    public class XmlDestination : PipelineComponent
    {

        public override IDTSCustomProperty100 SetComponentProperty(string propertyName, object propertyValue)
        {
            return base.SetComponentProperty(propertyName, propertyValue);
        }

        public override void ProvideComponentProperties()
        {
            base.ProvideComponentProperties();
        }

        public override void AcquireConnections(object transaction)
        {
            base.AcquireConnections(transaction);
        }

        public override void PrimeOutput(int outputs, int[] outputIDs, PipelineBuffer[] buffers)
        {
            base.PrimeOutput(outputs, outputIDs, buffers);
        }

        public override void PreExecute()
        {
            base.PreExecute();
        }

        public override DTSValidationStatus Validate()
        {
            return base.Validate();
        }

    }
}  

