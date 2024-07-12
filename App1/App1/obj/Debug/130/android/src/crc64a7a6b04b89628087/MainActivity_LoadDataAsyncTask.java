package crc64a7a6b04b89628087;


public class MainActivity_LoadDataAsyncTask
	extends android.os.AsyncTask
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_doInBackground:([Ljava/lang/Object;)Ljava/lang/Object;:GetDoInBackground_arrayLjava_lang_Object_Handler\n" +
			"n_onPostExecute:(Ljava/lang/Object;)V:GetOnPostExecute_Ljava_lang_Object_Handler\n" +
			"";
		mono.android.Runtime.register ("App1.MainActivity+LoadDataAsyncTask, App1", MainActivity_LoadDataAsyncTask.class, __md_methods);
	}


	public MainActivity_LoadDataAsyncTask ()
	{
		super ();
		if (getClass () == MainActivity_LoadDataAsyncTask.class) {
			mono.android.TypeManager.Activate ("App1.MainActivity+LoadDataAsyncTask, App1", "", this, new java.lang.Object[] {  });
		}
	}

	public MainActivity_LoadDataAsyncTask (crc64a7a6b04b89628087.MainActivity p0)
	{
		super ();
		if (getClass () == MainActivity_LoadDataAsyncTask.class) {
			mono.android.TypeManager.Activate ("App1.MainActivity+LoadDataAsyncTask, App1", "App1.MainActivity, App1", this, new java.lang.Object[] { p0 });
		}
	}


	public java.lang.Object doInBackground (java.lang.Object[] p0)
	{
		return n_doInBackground (p0);
	}

	private native java.lang.Object n_doInBackground (java.lang.Object[] p0);


	public void onPostExecute (java.lang.Object p0)
	{
		n_onPostExecute (p0);
	}

	private native void n_onPostExecute (java.lang.Object p0);

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
