﻿namespace Prueba.Api.Exceptions
{
	public class ErrorValidationResponse : ErrorModel
    {
		public IList<ErrorValidationModel> Errors { get; set; }
	}
}

