## Crate a new s3 bucket

'''sh
aws s3 mb s3://bucket-policy-examples-red-1234
'''

## Create bucket policy

'''sh
aws s3api put-bucket-policy --bucket bucket-policy-examples-red-1234 --policy file://policy.json
'''

## In the other Account, RC

'''sh
aws s3 ls s3://bucket-policy-examples-red-1234
touch redfile.txt
aws s3 cp redfile.txt s3://bucket-policy-examples-red-1234
aws s3 ls s3://bucket-policy-examples-red-1234
'''


## Clean up bucket and objects

'''sh
aws s3 rm s://bucket-policy-examamples-red-1234/redfile.txt
aws s3 rb s://bucket-policy-examamples-red-1234

'''