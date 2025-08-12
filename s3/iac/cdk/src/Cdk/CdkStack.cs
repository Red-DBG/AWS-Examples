using Amazon.CDK;
using Amazon.CDK.AWS.S3;
using Constructs;

namespace Cdk
{
    public class CdkStack : Stack
    {
        internal CdkStack(Construct scope, string id, IStackProps props = null) 
            : base(scope, id, props)
        {
            // Create an S3 bucket
            var bucket = new Bucket(this, "MyCdkBucket", new BucketProps
            {
                Versioned = false, // Enable versioning
                RemovalPolicy = RemovalPolicy.DESTROY, // Remove bucket when stack is deleted
                AutoDeleteObjects = true // Delete objects when bucket is destroyed
                
            });

            // Output the bucket name
            new CfnOutput(this, "BucketName", new CfnOutputProps
            {
                Value = bucket.BucketName
            });
        }
    }
}
