using ClubConnect.Api.Models.Servicios;

namespace ClubConnect.Api.Models
{
	public class ErrorViewModel
	{
		public string? RequestId { get; set; }

		public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);

	}
}
