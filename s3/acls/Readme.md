## Crate a new s3 bucket

'''sh
aws s3api create-bucket \
  --bucket acl-examples-red-1234 \
  --region ap-southeast-2 \
  --create-bucket-configuration LocationConstraint=ap-southeast-2
'''

## Create a file

'''md
echo "Hello ACLs!" > "myfile.txt"
echo "Hello ACLs!" > "myfile001.txt"
echo "Hello ACLs!" > "myfile002.txt"
'''

## Turn off Block Public Access for ACLs

'''sh
aws s3api put-public-access-block \
--bucket acl-examples-red-1234 \
--public-access-block-configuration "BlockPublicAcls=false,IgnorePublicAcls=false,BlockPublicPolicy=true,RestrictPublicBuckets=true"
'''

## Confirm

'''sh
aws s3api get-public-access-block \
--bucket acl-examples-red-1234 
'''

## Change Bucket Ownership

'''sh
aws s3api put-bucket-ownership-controls \
  --bucket acl-examples-red-1234 \
  --ownership-controls '{"Rules":[{"ObjectOwnership":"BucketOwnerPreferred"}]}'

'''

## Change ACLs to allow for a user in another AWS Account

'''sh
aws s3api put-bucket-acl \
--bucket acl-examples-red-1234 \
--access-control-policy file:///d/AWS Cert Training/AWS Examples/aws-examples/s3/acls/policy.json
'''

## Access Bucket from other account

'''sh
touch redfile.txt
aws s3 cp redfile.txt s3://acl-examples-red-1234
aws s3 ls s3://acl-examples-red-1234
'''

## Cleanup

'''sh
aws s3 rm s3://acl-examples-red-1234/redfile.txt
aws s3 rb s3://acl-examples-red-1234
'''