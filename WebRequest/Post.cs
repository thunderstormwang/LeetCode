using System;
using System.IO;
using System.Net;
using System.Text;

namespace WebRequest
{
    public class Post
    {
        public string POSTExample()
        {
            // 未驗證....為了測 HttpWebRequest ，造了很多 interface , 和實作...真麻煩....

            string targetUrl = "http://www.google.com";
            string parame = "p=Arvin";
            byte[] postData = Encoding.UTF8.GetBytes(parame);

            IHttpWebRequestFactory factory = new HttpWebRequestFactory();
            WrapHttpWebRequest request = factory.Create(targetUrl) as WrapHttpWebRequest;
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            request.Timeout = 30000;
            request.ContentLength = postData.Length;
            // 寫入 Post Body Message 資料流
            using (Stream st = request.GetRequestStream())
            {
                st.Write(postData, 0, postData.Length);
            }

            string result = "";
            // 取得回應資料
            using (WrapHttpWebResponse response = request.GetResponse() as WrapHttpWebResponse)
            {
                using (StreamReader sr = new StreamReader(response.GetResponseStream()))
                {
                    result = sr.ReadToEnd();
                }
            }

            return result;
        }
    }

    public interface IHttpWebRequest
    {
        // expose the members you need
        string Method { get; set; }

        IHttpWebResponse GetResponse();
    }

    public interface IHttpWebResponse : IDisposable
    {
        // expose the members you need
        Stream GetResponseStream();
    }

    public interface IHttpWebRequestFactory
    {
        IHttpWebRequest Create(string uri);
    }

    public class HttpWebRequestFactory : IHttpWebRequestFactory
    {
        public IHttpWebRequest Create(string uri)
        {
            return new WrapHttpWebRequest((HttpWebRequest)System.Net.WebRequest.Create(uri));
        }
    }

    // barebones implementation

    public class WrapHttpWebRequest : IHttpWebRequest
    {
        private readonly HttpWebRequest _request;

        public WrapHttpWebRequest(HttpWebRequest request)
        {
            _request = request;
        }

        public string Method
        {
            get { return _request.Method; }
            set { _request.Method = value; }
        }

        public string ContentType
        {
            get { return _request.ContentType; }
            set { _request.ContentType = value; }
        }

        public int Timeout
        {
            get { return _request.Timeout; }
            set { _request.Timeout = value; }
        }

        public long ContentLength
        {
            get { return _request.ContentLength; }
            set { _request.ContentLength = value; }
        }

        public IHttpWebResponse GetResponse()
        {
            return new WrapHttpWebResponse((HttpWebResponse)_request.GetResponse());
        }

        public Stream GetRequestStream()
        {
            return new MemoryStream();
        }
    }

    public class WrapHttpWebResponse : IHttpWebResponse
    {
        private WebResponse _response;

        public WrapHttpWebResponse(HttpWebResponse response)
        {
            _response = response;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_response != null)
                {
                    ((IDisposable)_response).Dispose();
                    _response = null;
                }
            }
        }

        public Stream GetResponseStream()
        {
            return _response.GetResponseStream();
        }
    }
}