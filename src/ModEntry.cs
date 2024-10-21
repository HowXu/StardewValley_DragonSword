using StardewModdingAPI;

namespace DragonSword;

public class ModEntry : Mod
{
    //这是Mod的入口类，实现了Mod接口的Mod会在这里被反射调用
    public override void Entry(IModHelper helper)
    {
        //throw new NotImplementedException();
        //helper参数可以实现Events等的调用
        Monitor.Log("Load Dragon Sword Mod ...",LogLevel.Info);
    }
}