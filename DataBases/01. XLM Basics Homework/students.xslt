<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
                xmlns:students="urn:students">
  <xsl:template match="/">
    <html>
      <body>
        <h1>Students</h1>
        <xsl:for-each select="students/student">
          <ul>
            <li>
              <strong>
                <xsl:value-of select="name" />
              </strong>
            </li>
            <ul>
              <li>
                <strong>Sex: </strong>
                <xsl:value-of select="sex" />
              </li>
              <li>
                <strong>Birth date: </strong>
                <xsl:value-of select="birthDate" />
              </li>
              <li>
                <strong>Phone: </strong>
                <xsl:value-of select="phone" />
              </li>
              <li>
                <strong>Email: </strong>
                <xsl:value-of select="email" />
              </li>
              <li>
                <strong>Course: </strong>
                <xsl:value-of select="course" />
              </li>
              <li>
                <strong>Specialty: </strong>
                <xsl:value-of select="specialty" />
              </li>
              <li>
                <strong>Faculty number: </strong>
                <xsl:value-of select="facultyNumber" />
              </li>
              <li>
                <strong>Exams: </strong>
                <xsl:for-each select="exams/exam">
                  <ul>
                    <li>
                      <strong><xsl:value-of select="name" /></strong>
                    </li>
                    <ul>
                      <li>
                        <strong>Date: </strong>
                        <xsl:value-of select="date" />
                      </li>
                      <li>
                        <strong>Score: </strong>
                        <xsl:value-of select="score" />
                      </li>
                      <li>
                        <strong>Tutor: </strong>
                        <xsl:value-of select="tutor/name" /> - <xsl:value-of select="tutor/endorsements" />
                      </li>
                    </ul>
                  </ul>
                </xsl:for-each>
              </li>
            </ul>
          </ul>
        </xsl:for-each>
      </body>
    </html>
  </xsl:template>
</xsl:stylesheet>
