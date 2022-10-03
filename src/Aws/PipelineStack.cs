using Amazon.CDK;
using Amazon.CDK.AWS.CodeCommit;
using Amazon.CDK.Pipelines;
using Constructs;

namespace Aws
{
    public class WorkshopPipelineStack : Stack
    {
        public WorkshopPipelineStack(Construct parent, string id, IStackProps props = null) : base(parent, id, props)
        {
            var repo = new Repository(this, "WorkshopRepo", new RepositoryProps
            {
                RepositoryName = "WorkshopRepo"
            });

            var pipeline = new CodePipeline(this, "Pipeline", new CodePipelineProps
            {
                PipelineName = "WorkshpPipeline",
                Synth = new ShellStep("Synth", new ShellStepProps
                {
                    Input = CodePipelineSource.CodeCommit(repo, "master"),
                    Commands = new string[]
                    {
                        "npm install -g aws-cdk",
                        "sudo apt-get install -y dotnet-sdk-3.1",
                        "dotnet build"
                    }
                })
            });
        }
    }
}
