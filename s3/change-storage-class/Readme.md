## Crate a new s3 bucket

'''md
aws s3 mb s3://change-storage-class-examamples-red-1234
'''


## Create a file

'''md
echo "Hello Change Storage Class!" > myfile.txt
'''

## Create an s3 object and see the storage class with default on, STANDARD

'''md
aws s3api put-object \
  --bucket change-storage-class-examamples-red-1234 \
  --key myfile.txt \
  --body ./myfile.txt \
  --metadata hello=metadata,owner=red

  aws s3 cp myfile002.txt s3://change-storage-class-examamples-red-1234/
'''

## Change storage class
'''sh
  aws s3 cp myfile002.txt s3://change-storage-class-examamples-red-1234/ --storage-class STANDARD-IA
'''

## Get Object's Metadata
'''sh
aws s3api head-object --bucket change-storage-class-examamples-red-1234 --key "myfile.txt"

'''

## Clean up bucket and objects

'''sh
aws s3 rm s://change-storage-class-examamples-red-1234/myfile.txt
aws s3 rm s://change-storage-class-examamples-red-1234/myfile002.txt
aws s3 rb s://change-storage-class-examamples-red-1234

'''