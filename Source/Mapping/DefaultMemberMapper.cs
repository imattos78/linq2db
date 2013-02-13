using System;

namespace LinqToDB.Mapping
{
	class DefaultMemberMapper : MemberMapper
	{
		public override object GetValue(object o)
		{
			return MapTo(base.GetValue(o));
		}

		public override void SetValue(object o, object value)
		{
			base.SetValue(o, MapFrom(value));
		}
	}
}
