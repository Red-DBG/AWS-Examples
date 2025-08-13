## Crate a new s3 bucket

'''md
aws s3 mb s3://checksums-examamples-red-1234
'''

## Create a file that we will do a checksum on

'''md
echo "Hello Red!" > myfile.txt
'''

## Get a checksum of a file fro md5

'''md
md5sum myfile.txt
# 53e076499416205ac79227d591c01d0e *myfile.txt
'''

## Upload our file and look its etag

'''md
aws s3 cp myfile.txt s3://checksums-examamples-red-1234
aws s3api head-object --bucket checksums-examamples-red-1234 --key myfile.txt
'''

## Lets upload a file with different kind of checksum

'''sh
wsl
sudo apt install libarchive-zip-perl
sudo apt-get install crc32
crc32 myfile.txt > 1a3c7c97
'''

'''sh
# CRC32 checksum to be Base64-encoded
# from 1a3c7c97 to Gjx8lw==

echo 1a3c7c97 | xxd -r -p | base64
> Gjx8lw==

 aws s3api put-object \
  --bucket checksums-examamples-red-1234 \
  --key myfile.txt \
  --body myfile.txt \
  --checksum-algorithm CRC32 \
  --checksum-crc32 Gjx8lw==
  
  >
    {
        "ETag": "\"53e076499416205ac79227d591c01d0e\"",
        "ChecksumCRC32": "Gjx8lw==",
        "ChecksumType": "FULL_OBJECT",
        "ServerSideEncryption": "AES256"
    }
'''
