cd StudentAPI/
rm -r dist/
dotnet publish -o dist
cd ..
cd BlazorClient/
rm -r dist/
dotnet publish -o dist
cd ..