using Amazon.CDK;
using Constructs;

namespace Aws
{
    public class PipelineStage : Stage
    {
        public PipelineStage(Construct scope, string id, IStageProps props = null) : base(scope, id, props)
        {
            var service = new AwsStack(this, "WebService");
        }
    }
}
