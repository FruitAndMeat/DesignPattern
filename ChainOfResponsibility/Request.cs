namespace ChainOfResponsibility
{
    public class Request
    {
		private string requestType;
		/// <summary>
		/// 申请类别
		/// </summary>
		public string RequestType {
			get { return requestType; }
			set { requestType = value; }
		}

		private string requestContent;
		/// <summary>
		/// 申请内容
		/// </summary>
		public string RequestContent {
			get { return requestContent; }
			set { requestContent = value; }
		}

		private int number;
		/// <summary>
		/// 数量
		/// </summary>
		public int Number {
			get { return number; }
			set { number = value; }
		}

	}
}