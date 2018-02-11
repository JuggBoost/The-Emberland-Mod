using Terraria.ModLoader;

namespace Emberland
{
	class Emberland : Mod
	{
		public Emberland()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true
			};
		}
	}
}
