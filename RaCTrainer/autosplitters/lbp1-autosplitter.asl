state("racman") {}

startup
{    

}

init
{
    System.IO.MemoryMappedFiles.MemoryMappedFile mmf = System.IO.MemoryMappedFiles.MemoryMappedFile.OpenExisting("racman-autosplitter");
    System.IO.MemoryMappedFiles.MemoryMappedViewStream stream = mmf.CreateViewStream();
    vars.reader = new System.IO.BinaryReader(stream);
    
    vars.reader.BaseStream.Position = 0;

    current.LV1 = vars.reader.ReadUInt32();

}

update
{
    vars.reader.BaseStream.Position = 0;

    current.LV1 = vars.reader.ReadUInt32();

}

start
{

}

reset
{

}

split
{
  
}

isLoading 
{
    
    return (current.LV1 > 0);
}