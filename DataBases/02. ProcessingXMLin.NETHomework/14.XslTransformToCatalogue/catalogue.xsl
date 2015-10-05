<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  <xsl:output method="xml" indent="yes"/>

  <xsl:template match="/">
    <html>
      <body>
        <h1>Catalogue</h1>
        <xsl:for-each select="catalogue/album">
          <ul>
            <li>
              <strong>
                <xsl:value-of select="name"/>
              </strong>
              <ul>
                <li>
                  <strong>Artist: </strong>
                  <xsl:value-of select="artist"/>
                </li>
                <li>
                  <strong>Year: </strong>
                  <xsl:value-of select="year"/>
                </li>
                <li>
                  <strong>Produser: </strong>
                  <xsl:value-of select="produser"/>
                </li>
                <li>
                  <strong>Price: </strong>
                  USD <xsl:value-of select="price"/>
                </li>
                <li>
                  <strong>Songs: </strong>
                  <ul>
                    <xsl:for-each select="songs/song">
                      <li>
                        <xsl:value-of select="title"/> - <xsl:value-of select="duration"/>
                      </li>
                    </xsl:for-each>
                  </ul>
                </li>
              </ul>
            </li>
          </ul>
        </xsl:for-each>
      </body>
    </html>
  </xsl:template>
</xsl:stylesheet>
