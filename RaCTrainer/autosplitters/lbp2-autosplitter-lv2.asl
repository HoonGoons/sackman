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
    current.LV2 = vars.reader.ReadUInt32();
    current.LV3 = vars.reader.ReadUInt32();

    vars.disableLV1 = false;
}

update
{
    vars.reader.BaseStream.Position = 0;

    current.LV1 = vars.reader.ReadUInt32();
    current.LV2 = vars.reader.ReadUInt32();
    current.LV3 = vars.reader.ReadUInt32();

    if (current.LV1 > 0 && current.LV2 == 1) {
        vars.disableLV1 = true;
    }

    if (current.LV1 == 0 && current.LV2 == 0) {
        vars.disableLV1 = false;
    }
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
    
    return (current.LV1 > 0 && !vars.disableLV1) || (current.LV2 > 0) || (current.LV3 > 0);
}