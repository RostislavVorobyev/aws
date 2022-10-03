using Amazon.CDK;

namespace Aws
{
    sealed class Program
    {
        public static void Main(string[] args)
        {
            var app = new App();
            new PipelineStack(app, "WorkshopPipelineStack");
            app.Synth();
        }
    }
}
