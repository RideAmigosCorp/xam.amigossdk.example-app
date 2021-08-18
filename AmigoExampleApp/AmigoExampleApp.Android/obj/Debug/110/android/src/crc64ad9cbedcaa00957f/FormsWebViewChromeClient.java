package crc64ad9cbedcaa00957f;


public class FormsWebViewChromeClient
	extends android.webkit.WebChromeClient
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("AmigosSDK.Droid.FormsWebViewChromeClient, AmigosSDK.Droid", FormsWebViewChromeClient.class, __md_methods);
	}


	public FormsWebViewChromeClient ()
	{
		super ();
		if (getClass () == FormsWebViewChromeClient.class)
			mono.android.TypeManager.Activate ("AmigosSDK.Droid.FormsWebViewChromeClient, AmigosSDK.Droid", "", this, new java.lang.Object[] {  });
	}

	public FormsWebViewChromeClient (crc64ad9cbedcaa00957f.FormsWebViewRenderer p0)
	{
		super ();
		if (getClass () == FormsWebViewChromeClient.class)
			mono.android.TypeManager.Activate ("AmigosSDK.Droid.FormsWebViewChromeClient, AmigosSDK.Droid", "AmigosSDK.Droid.FormsWebViewRenderer, AmigosSDK.Droid", this, new java.lang.Object[] { p0 });
	}

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
