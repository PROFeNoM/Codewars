public class ProdFib {
      public static ulong[] productFib(ulong prod) {
            ulong m = 0;
            ulong m_plus = 1;
            while (m * m_plus < prod){
                m_plus = m + m_plus;
                m = m_plus - m;
            }
            return new ulong[] { m, m_plus, m*m_plus == prod ? (ulong)1 : (ulong)0};
      }
}
