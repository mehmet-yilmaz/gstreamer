sbc_sources = [
  'sbc-plugin.c',
  'gstsbcdec.c',
  'gstsbcenc.c',
]

sbc_headers = [
  'gstsbcdec.h',
  'gstsbcenc.h',
]

doc_sources = []
foreach s: sbc_sources + sbc_headers
  doc_sources += meson.current_source_dir() / s
endforeach

plugin_sources += {
  'sbc': pathsep.join(doc_sources)
}

sbc_dep = dependency('sbc', version : '>= 1.0', required : get_option('sbc'))

if sbc_dep.found()
  gstsbc = library('gstsbc',
    sbc_sources,
    c_args : gst_plugins_bad_args,
    include_directories : [configinc],
    dependencies : [gstaudio_dep, sbc_dep],
    install : true,
    install_dir : plugins_install_dir,
  )
  plugins += [gstsbc]
endif
