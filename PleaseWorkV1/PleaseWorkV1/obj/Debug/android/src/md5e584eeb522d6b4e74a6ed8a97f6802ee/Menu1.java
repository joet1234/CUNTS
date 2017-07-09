package md5e584eeb522d6b4e74a6ed8a97f6802ee;


public class Menu1
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("PleaseWorkV1.Menu1, PleaseWorkV1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", Menu1.class, __md_methods);
	}


	public Menu1 () throws java.lang.Throwable
	{
		super ();
		if (getClass () == Menu1.class)
			mono.android.TypeManager.Activate ("PleaseWorkV1.Menu1, PleaseWorkV1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
