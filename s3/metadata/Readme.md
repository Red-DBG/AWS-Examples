## Crate a new s3 bucket

'''md
aws s3 mb s3://metadata-examamples-red-1234
'''


## Create a file

'''md
echo "Hello Metadata!" > myfile.txt
'''

## Create an s3 object with metadata in it

'''md
aws s3api put-object \
  --bucket metadata-examamples-red-1234 \
  --key myfile.txt \
  --body ./myfile.txt \
  --metadata hello=metadata owner=red
'''

## Get Object's Metadata
'''sh
aws s3api head-object --bucket metadata-examamples-red-1234 --key "myfile.txt"

'''

## Clean up bucket and objects

'''sh
aws s3 rm s://metadata-examamples-red-1234/myfile.txt
aws s3 rm s://metadata-examamples-red-1234/myfile002.txt
aws s3 rm s://metadata-examamples-red-1234/myfile003.txt
aws s3 rb s://metadata-examamples-red-1234

'''