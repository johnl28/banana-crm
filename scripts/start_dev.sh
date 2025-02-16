#!/bin/bash


echo "Starting MYSQL container";
docker container start mysql_dev;


echo "Starting API";
dotnet watch ./src/API




