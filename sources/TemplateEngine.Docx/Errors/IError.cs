using System;

namespace TemplateEngine.Docx.Errors
{
	public interface IError:IEquatable<IError>
	{
		string Message { get; }
	}
}
