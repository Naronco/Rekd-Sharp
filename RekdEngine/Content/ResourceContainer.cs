using RekdEngine.Debug;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RekdEngine.Content
{
	public class ResourceContainer : DynamicObject
	{
		private static Dictionary<string, Texture2D> Textures = new Dictionary<string, Texture2D>();

		public override bool TryGetMember(GetMemberBinder binder, out object result)
		{
			result = null;
			if (Textures.ContainsKey(binder.Name))
			{
				result = Textures[binder.Name];
				return true;
			}
			else
				return false;
		}

		public void Load(ContentManager content)
		{
			LoadResources(content, "Textures/", (name, file) => Textures.Add(name, content.Load<Texture2D>(file)));
		}

		private void LoadResources(ContentManager content, string path, Action<string, string> callback)
		{
			if (Directory.Exists(content.ContentDirectory + path))
				Directory.EnumerateFiles(content.ContentDirectory + path).ToList()
					.ForEach(file =>
						callback(Path.GetFileNameWithoutExtension(file), file.Substring(content.ContentDirectory.Length))
					);
			else
				DebugWrite.Log("Couldn't load resource folder " + content.ContentDirectory + path);
		}
	}
}