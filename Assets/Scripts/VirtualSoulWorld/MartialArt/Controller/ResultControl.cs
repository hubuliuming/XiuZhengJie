using Game;
using QFramework;

namespace MartialArt
{
	public partial class ResultControl : ViewController,ICanSendEvent
	{
		void Start()
		{
			BtnClose.onClick.AddListener(Hide);
		}

		internal void Open()
		{
			gameObject.SetActive(true);
		}

		internal void Hide()
		{
			gameObject.SetActive(false);
			this.GetArchitecture().SendEvent<ResetAllEvent>();
		}

		public IArchitecture GetArchitecture()
		{
			return VirtualSoulWorld.Interface;
		}
	}
}
